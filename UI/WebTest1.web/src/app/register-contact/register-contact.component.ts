import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Contact } from '../../Model/contact.model';
import { ContactService } from '../contact.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-register-contact',
  imports: [FormsModule, ReactiveFormsModule,CommonModule],
  templateUrl: './register-contact.component.html',
  styleUrl: './register-contact.component.css'
})
export class RegisterContactComponent {
  contact: Contact = {
    name: '',
    email: '',
    phone: '',
  };

  constructor(private contactService: ContactService) {}

  registerContact(): void {
    this.contactService.registerContact(this.contact).subscribe(
      (response) => {
        console.log('Contact registered successfully:', response);
        alert('Contact registered successfully!');
        this.contact = { name: '', email: '', phone: ''}; // Reiniciar el formulario
      },
      (error) => {
        console.error('Error registering contact:', error);
        alert('Failed to register contact.');
      }
    );
  }
}
