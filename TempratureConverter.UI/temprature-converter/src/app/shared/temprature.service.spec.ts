import { TestBed } from '@angular/core/testing';

import { TempratureService } from './temprature.service';

describe('TempratureService', () => {
  let service: TempratureService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TempratureService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
