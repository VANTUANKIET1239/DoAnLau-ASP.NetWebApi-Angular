/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { TrangGioHangComponent } from './TrangGioHang.component';

describe('TrangGioHangComponent', () => {
  let component: TrangGioHangComponent;
  let fixture: ComponentFixture<TrangGioHangComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TrangGioHangComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TrangGioHangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
