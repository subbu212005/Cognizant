import { TestBed } from '@angular/core/testing';
import { HttpClient, provideHttpClient, withInterceptors } from '@angular/common/http';
import { HttpTestingController, provideHttpClientTesting } from '@angular/common/http/testing';
import { loadingInterceptor } from './loading.interceptor';
import { LoadingService } from '../services/loading.service';

describe('loadingInterceptor', () => {
  let httpMock: HttpTestingController;
  let httpClient: HttpClient;
  let loadingService: LoadingService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: LoadingService,
          useValue: {
            show: vi.fn(),
            hide: vi.fn()
          }
        },
        provideHttpClient(withInterceptors([loadingInterceptor])),
        provideHttpClientTesting()
      ]
    });

    httpMock = TestBed.inject(HttpTestingController);
    httpClient = TestBed.inject(HttpClient);
    loadingService = TestBed.inject(LoadingService);
  });

  afterEach(() => {
    httpMock.verify();
  });

  it('should call loadingService.show on start and loadingService.hide on completion', () => {
    httpClient.get('/api/test').subscribe();

    expect(loadingService.show).toHaveBeenCalledTimes(1);
    expect(loadingService.hide).not.toHaveBeenCalled();

    const req = httpMock.expectOne('/api/test');
    req.flush({});

    expect(loadingService.hide).toHaveBeenCalledTimes(1);
  });

  it('should call loadingService.hide even on request failure', () => {
    httpClient.get('/api/test').subscribe({
      next: () => {},
      error: () => {}
    });

    expect(loadingService.show).toHaveBeenCalledTimes(1);

    const req = httpMock.expectOne('/api/test');
    req.error(new ErrorEvent('Network error'));

    expect(loadingService.hide).toHaveBeenCalledTimes(1);
  });
});
