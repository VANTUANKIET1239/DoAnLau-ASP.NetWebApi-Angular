/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { TrangChiTietUuDaiComponent } from './TrangChiTietUuDai.component';

describe('TrangChiTietUuDaiComponent', () => {
  let component: TrangChiTietUuDaiComponent;
  let fixture: ComponentFixture<TrangChiTietUuDaiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TrangChiTietUuDaiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TrangChiTietUuDaiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
