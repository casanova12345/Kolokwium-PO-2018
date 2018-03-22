package rezerwacja.rezerwacja_obiektow;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
@ComponentScan("rezerwacja")
public class RezerwacjaObiektowApplication {

	public static void main(String[] args) {
		SpringApplication.run(RezerwacjaObiektowApplication.class, args);
	}
}
