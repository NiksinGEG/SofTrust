

export class User {
    id?: number;
    name: string;
    mail: string;
    phoneNumber: string;
    selectedTheme?: number;
    message: string;

    constructor(name: string, mail: string, phoneNumber: string, message: string) {
        this.name = name;
        this.mail = mail;
        this.phoneNumber = phoneNumber;
        this.message = message;
    }
}
