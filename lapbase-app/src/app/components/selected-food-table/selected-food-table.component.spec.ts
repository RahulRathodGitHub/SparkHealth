import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SelectedFoodTableComponent } from './selected-food-table.component';

describe('SelectedFoodTableComponent', () => {
  let component: SelectedFoodTableComponent;
  let fixture: ComponentFixture<SelectedFoodTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SelectedFoodTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SelectedFoodTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
