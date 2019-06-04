import { IFoodIntakeList } from './../../../models/foodIntakeList';
import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';
import { TaskService } from 'src/app/services';
import { IFood, IFoodIntakeListDto } from 'src/app/models';

@Component({
  selector: 'app-food-entry',
  templateUrl: './food-entry.component.html',
  styleUrls: ['./food-entry.component.scss']
})
export class FoodEntryComponent implements OnInit {
  @Input() selectedTaskId: string;
  @Output() nextHandler = new EventEmitter();
  @Output() backHandler = new EventEmitter();

  step: number;
  selectedFoodQuantity: IFoodIntakeList;

  constructor(private taskService: TaskService) {
    this.step = 0;
  }

  ngOnInit() {
    this.selectedFoodQuantity = {
      id: '00000000-0000-0000-0000-000000000000', // Make this an emty guid
      food: [],
      quantity: [],
      dateEntered: new Date(),
      taskId: this.selectedTaskId
     };
  }

  onFoodSubmit(selectedFoodIds: IFood[]) {
    selectedFoodIds.forEach(f => {
      if (!this.selectedFoodQuantity.food.find(food => food.id === f.id)) {
        this.selectedFoodQuantity.food.push(f);
        this.selectedFoodQuantity.quantity.push(0);
      }
    });
    this.step--;
  }

  onSubmit() {
    this.taskService.sendFoodIntake(this.mapToDto(this.selectedFoodQuantity)).then(() => this.backHandler.emit());
  }

  onNext() {
    this.step++;
  }

  onCancel() {
    this.step--;
  }

  onBack() {
    this.backHandler.emit();
  }

  findIndexOfFood(foodId: string) {
    return this.selectedFoodQuantity.food.findIndex(f => f.id === foodId);
  }

  minusQuantity(foodId: string) {
    this.selectedFoodQuantity.quantity[this.findIndexOfFood(foodId)]--;
  }
  addQuantity(foodId: string) {
    this.selectedFoodQuantity.quantity[this.findIndexOfFood(foodId)]++;
  }

  removeFood(foodId: string) {
    const index = this.selectedFoodQuantity.food.findIndex(f => f.id === foodId);
    this.selectedFoodQuantity.food.splice(index, 1);
    this.selectedFoodQuantity.quantity.splice(index, 1);
  }

  alreadySelectedFood = () => this.selectedFoodQuantity.food.map(food => food.id);

  mapToDto = (selectedFoodQuantity: IFoodIntakeList): IFoodIntakeListDto => {
    const list: IFoodIntakeListDto = {
      id: this.selectedFoodQuantity.id,
      taskId: this.selectedFoodQuantity.taskId,
      dateEntered: selectedFoodQuantity.dateEntered,
      food: selectedFoodQuantity.food.reduce((a, b) => a + ';' + b, this.selectedFoodQuantity.food[0].id),
      quantity: selectedFoodQuantity.food.reduce((a, b) => a + ';' + b, this.selectedFoodQuantity.quantity[0].toString())
    };
    return list;
  }
}
