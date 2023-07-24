/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { DangKyComponent } from './DangKy.component';

describe('DangKyComponent', () => {
  let component: DangKyComponent;
  let fixture: ComponentFixture<DangKyComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DangKyComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DangKyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
