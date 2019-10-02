import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ExerciseChoicesComponent } from './exercise-choices.component';

describe('ExerciseChoicesComponent', () => {
  let component: ExerciseChoicesComponent;
  let fixture: ComponentFixture<ExerciseChoicesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ExerciseChoicesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ExerciseChoicesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
