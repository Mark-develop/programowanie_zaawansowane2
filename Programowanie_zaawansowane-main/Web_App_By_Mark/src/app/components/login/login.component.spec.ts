import { LoginComponent } from "./login.component";

describe('testing login form', () => {
    it('wrong credentials no let in', () => {
    const service = new LoginComponent;
    service.formData.username = '1'
    service.formData.password = '4'
    service.login();
    expect(service.formData.isLoged).toBe(false);
    });

    it('right credentials let log-in', () => {
        const service = new LoginComponent;
        service.formData.username = 'Mark'
        service.formData.password = '123'
        service.login();
        expect(service.formData.isLoged).toBe(true);
    });
});