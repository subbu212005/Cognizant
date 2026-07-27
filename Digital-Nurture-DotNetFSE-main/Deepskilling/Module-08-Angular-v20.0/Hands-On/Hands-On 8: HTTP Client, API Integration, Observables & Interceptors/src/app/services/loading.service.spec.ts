import { TestBed } from '@angular/core/testing';
import { LoadingService } from './loading.service';

describe('LoadingService', () => {
  let service: LoadingService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [LoadingService]
    });
    service = TestBed.inject(LoadingService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should initialize with isLoading false', () => {
    expect(service.isLoading()).toBe(false);
  });

  it('should set isLoading to true when show is called', () => {
    service.show();
    expect(service.isLoading()).toBe(true);
  });

  it('should set isLoading to false when show and hide are called', () => {
    service.show();
    service.hide();
    expect(service.isLoading()).toBe(false);
  });

  it('should support multiple concurrent operations', () => {
    service.show(); // count = 1
    service.show(); // count = 2
    expect(service.isLoading()).toBe(true);

    service.hide(); // count = 1
    expect(service.isLoading()).toBe(true);

    service.hide(); // count = 0
    expect(service.isLoading()).toBe(false);
  });

  it('should clamp loading count to 0 and not go negative', () => {
    service.hide(); // count = 0
    expect(service.isLoading()).toBe(false);

    service.show(); // count = 1
    service.hide(); // count = 0
    service.hide(); // count = 0 (clamped)
    expect(service.isLoading()).toBe(false);
  });
});
