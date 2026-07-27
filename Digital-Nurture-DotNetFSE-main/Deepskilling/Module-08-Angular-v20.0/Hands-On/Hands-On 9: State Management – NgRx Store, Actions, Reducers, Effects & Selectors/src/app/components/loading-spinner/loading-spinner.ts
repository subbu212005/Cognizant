import { Component, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoadingService } from '../../services/loading.service';

@Component({
  selector: 'app-loading-spinner',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './loading-spinner.html',
  styleUrl: './loading-spinner.css'
})
export class LoadingSpinnerComponent {
  private loadingService = inject(LoadingService);
  isLoading = this.loadingService.isLoading;
}
