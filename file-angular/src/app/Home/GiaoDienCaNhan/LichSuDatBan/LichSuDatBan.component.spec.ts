/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { LichSuDatBanComponent } from './LichSuDatBan.component';

describe('LichSuDatBanComponent', () => {
  let component: LichSuDatBanComponent;
  let fixture: ComponentFixture<LichSuDatBanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LichSuDatBanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LichSuDatBanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
