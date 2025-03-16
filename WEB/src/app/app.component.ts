import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  accountService = inject(AccountService);
  title = 'FarmacyRVA';
  description = 'Welcome to the freshest fruits and veggies market, FarmacyRVA. We provide seasonal, fresh produce straight from local fields to various places, so you may live a better, happier life.';
  logo = 'assets/logo.png';
  logoAlt = 'FarmacyRVA Logo';

  ngOnInit(): void {
    var x = 5;
  }
  
}
