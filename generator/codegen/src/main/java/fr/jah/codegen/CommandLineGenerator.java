package fr.jah.codegen;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;

@Component
public class CommandLineGenerator implements CommandLineRunner {

    @Autowired
    private TemplateBuilder builder;

    @Override
    public void run(String... arg0) throws Exception {
        builder.generateSourceFile();
    }
}
