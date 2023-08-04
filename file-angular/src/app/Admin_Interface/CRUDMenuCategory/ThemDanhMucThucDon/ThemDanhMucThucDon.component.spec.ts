/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ThemDanhMucThucDonComponent } from './ThemDanhMucThucDon.component';

describe('ThemDanhMucThucDonComponent', () => {
  let component: ThemDanhMucThucDonComponent;
  let fixture: ComponentFixture<ThemDanhMucThucDonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ThemDanhMucThucDonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ThemDanhMucThucDonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
