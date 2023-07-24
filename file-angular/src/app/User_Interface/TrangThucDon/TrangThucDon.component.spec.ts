/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { TrangThucDonComponent } from './TrangThucDon.component';

describe('TrangThucDonComponent', () => {
  let component: TrangThucDonComponent;
  let fixture: ComponentFixture<TrangThucDonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TrangThucDonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TrangThucDonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
