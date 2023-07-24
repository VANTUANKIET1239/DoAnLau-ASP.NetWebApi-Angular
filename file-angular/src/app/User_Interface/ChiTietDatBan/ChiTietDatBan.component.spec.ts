/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ChiTietDatBanComponent } from './ChiTietDatBan.component';

describe('ChiTietDatBanComponent', () => {
  let component: ChiTietDatBanComponent;
  let fixture: ComponentFixture<ChiTietDatBanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChiTietDatBanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChiTietDatBanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
