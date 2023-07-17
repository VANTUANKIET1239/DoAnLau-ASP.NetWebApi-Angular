/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { TrangThanhToanComponent } from './TrangThanhToan.component';

describe('TrangThanhToanComponent', () => {
  let component: TrangThanhToanComponent;
  let fixture: ComponentFixture<TrangThanhToanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TrangThanhToanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TrangThanhToanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
