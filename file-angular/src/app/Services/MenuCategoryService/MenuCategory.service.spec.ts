/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { MenuCategoryService } from './MenuCategory.service';

describe('Service: MenuCategory', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [MenuCategoryService]
    });
  });

  it('should ...', inject([MenuCategoryService], (service: MenuCategoryService) => {
    expect(service).toBeTruthy();
  }));
});
