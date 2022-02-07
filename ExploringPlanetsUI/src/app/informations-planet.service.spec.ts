import { TestBed } from '@angular/core/testing';

import { InformationsPlanetService } from './informations-planet.service';

describe('InformationsPlanetService', () => {
  let service: InformationsPlanetService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(InformationsPlanetService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
