/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { BestSallerComponent } from './BestSaller.component';

describe('BestSallerComponent', () => {
  let component: BestSallerComponent;
  let fixture: ComponentFixture<BestSallerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BestSallerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BestSallerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
