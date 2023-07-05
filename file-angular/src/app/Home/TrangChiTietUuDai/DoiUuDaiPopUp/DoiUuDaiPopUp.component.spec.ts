/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { DoiUuDaiPopUpComponent } from './DoiUuDaiPopUp.component';

describe('DoiUuDaiPopUpComponent', () => {
  let component: DoiUuDaiPopUpComponent;
  let fixture: ComponentFixture<DoiUuDaiPopUpComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DoiUuDaiPopUpComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DoiUuDaiPopUpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
