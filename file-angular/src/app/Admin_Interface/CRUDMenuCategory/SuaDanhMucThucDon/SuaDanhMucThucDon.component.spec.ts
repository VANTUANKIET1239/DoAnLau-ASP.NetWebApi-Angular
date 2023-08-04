/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { SuaDanhMucThucDonComponent } from './SuaDanhMucThucDon.component';

describe('SuaDanhMucThucDonComponent', () => {
  let component: SuaDanhMucThucDonComponent;
  let fixture: ComponentFixture<SuaDanhMucThucDonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SuaDanhMucThucDonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SuaDanhMucThucDonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
