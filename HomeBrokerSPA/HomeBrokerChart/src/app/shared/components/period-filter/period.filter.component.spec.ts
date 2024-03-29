import { ComponentFixture, TestBed } from '@angular/core/testing';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PeriodFilterComponent } from './period.filter.component';
import { PeriodStartDateObservable, PeriodEndDateObservable } from '../../observables';

describe('PeriodFilterComponent', () => {
  let component: PeriodFilterComponent;
  let fixture: ComponentFixture<PeriodFilterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CommonModule, FormsModule, ReactiveFormsModule],
      providers: [PeriodStartDateObservable, PeriodEndDateObservable]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PeriodFilterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

});
