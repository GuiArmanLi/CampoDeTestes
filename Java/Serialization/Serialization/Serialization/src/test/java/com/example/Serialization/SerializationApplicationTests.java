package com.example.Serialization;

import static org.junit.jupiter.api.Assertions.assertTrue;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;

import com.example.Serialization.person.PersonModel;

@SpringBootTest
class SerializationApplicationTests {

	@Test
	void contextLoads() {
	}

	@Test
	public void whenSerializingAndDeserializing_ThenObjectIsTheSame() throws IOException, ClassNotFoundException {
		PersonModel person = new PersonModel();
		person.setAge(20);
		person.setName("Joe");

		FileOutputStream fileOutputStream = new FileOutputStream("yourfile.txt");
		ObjectOutputStream objectOutputStream = new ObjectOutputStream(fileOutputStream);
		objectOutputStream.writeObject(person);
		objectOutputStream.flush();
		objectOutputStream.close();

		FileInputStream fileInputStream = new FileInputStream("yourfile.txt");
		ObjectInputStream objectInputStream = new ObjectInputStream(fileInputStream);
		PersonModel p2 = (PersonModel) objectInputStream.readObject();
		objectInputStream.close();

		assertTrue(p2.getAge() == person.getAge());
		assertTrue(p2.getName().equals(person.getName()));
	}

}
