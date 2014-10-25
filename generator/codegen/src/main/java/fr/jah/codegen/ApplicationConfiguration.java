package fr.jah.codegen;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.ui.velocity.VelocityEngineFactory;

@ComponentScan
@Configuration
public class ApplicationConfiguration {

    @Bean
    public VelocityEngineFactory buildVelocityFactory() {
        VelocityEngineFactory factory = new VelocityEngineFactory();
        factory.setResourceLoaderPath("file:d:/tmp/templates");
        return factory;
    }
}
