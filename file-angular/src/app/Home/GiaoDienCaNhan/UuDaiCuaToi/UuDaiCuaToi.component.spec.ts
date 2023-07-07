/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { UuDaiCuaToiComponent } from './UuDaiCuaToi.component';

describe('UuDaiCuaToiComponent', () => {
  let component: UuDaiCuaToiComponent;
  let fixture: ComponentFixture<UuDaiCuaToiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UuDaiCuaToiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UuDaiCuaToiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
