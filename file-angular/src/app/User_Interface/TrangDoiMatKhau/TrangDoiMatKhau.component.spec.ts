/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { TrangDoiMatKhauComponent } from './TrangDoiMatKhau.component';

describe('TrangDoiMatKhauComponent', () => {
  let component: TrangDoiMatKhauComponent;
  let fixture: ComponentFixture<TrangDoiMatKhauComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TrangDoiMatKhauComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TrangDoiMatKhauComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
