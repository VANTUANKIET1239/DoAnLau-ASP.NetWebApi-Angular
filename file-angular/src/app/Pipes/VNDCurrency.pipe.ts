import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'VNDCurrency'
})
export class VNDCurrencyPipe implements PipeTransform {

  transform(value: any): string {
    if (isNaN(value)) {
      return '0 VND';
    }
    // Format the number to VND currency format
    const formattedValue = new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(value);

    return formattedValue;
  }

}
