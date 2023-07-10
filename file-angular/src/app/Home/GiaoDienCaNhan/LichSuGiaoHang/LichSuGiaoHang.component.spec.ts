/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { LichSuGiaoHangComponent } from './LichSuGiaoHang.component';

describe('LichSuGiaoHangComponent', () => {
  let component: LichSuGiaoHangComponent;
  let fixture: ComponentFixture<LichSuGiaoHangComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LichSuGiaoHangComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LichSuGiaoHangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
