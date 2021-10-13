import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormShippersComponent } from './form-shippers.component';

describe('FormShippersComponent', () => {
  let component: FormShippersComponent;
  let fixture: ComponentFixture<FormShippersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormShippersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormShippersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
