/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { TrangUuDaiComponent } from './TrangUuDai.component';

describe('TrangUuDaiComponent', () => {
  let component: TrangUuDaiComponent;
  let fixture: ComponentFixture<TrangUuDaiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TrangUuDaiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TrangUuDaiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
