/**
 * 
 */
package fr.jah.codegen;

import java.io.FileWriter;
import java.io.IOException;
import java.io.Serializable;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import lombok.Getter;
import lombok.Setter;
import lombok.extern.slf4j.Slf4j;

import org.apache.velocity.exception.VelocityException;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import org.springframework.ui.velocity.VelocityEngineFactory;
import org.springframework.ui.velocity.VelocityEngineUtils;

/**
 * @author mvincent
 */
@Slf4j
@Component
public class TemplateBuilder implements Serializable {

    /** Velocity engine factory. */
    @Autowired
    private transient VelocityEngineFactory velocityEngine;

    /**
     * @throws VelocityException
     * @throws IOException
     */
    public void generateSourceFile() throws VelocityException, IOException {
        FileWriter writer = new FileWriter("interface.java");

        Element newClass = new Element();
        newClass.setName("Toto");
        newClass.setNamespace("fr.jah.codegen");
        newClass.setType("interface");
        newClass.setVisibility("public");

        // List<String> intfcs = new ArrayList<String>();
        // intfcs.add("Serializable");
        // newClass.setInterfaces(intfcs);

        Map<String, Object> input = new HashMap<String, Object>();
        input.put("foo", newClass);
        input.put("toto", 12344);
        VelocityEngineUtils.mergeTemplate(velocityEngine.createVelocityEngine(), "java.interface.vm", "UTF-8", input, writer);
        writer.close();
        log.debug("File generated");
    }

    public class Element implements Serializable {

        @Getter
        @Setter
        public String namespace;
        @Getter
        @Setter
        public List<String> imports;
        @Getter
        @Setter
        public String visibility;
        @Getter
        @Setter
        public String type;
        @Getter
        @Setter
        public String name;
        @Getter
        @Setter
        public List<String> interfaces;
        @Getter
        @Setter
        public String extension;
    }

    public class Annotation implements Serializable {

        @Getter
        @Setter
        public List<Param> params;
    }

    public class Method implements Serializable {
        @Getter
        @Setter
        public String description;
        @Getter
        @Setter
        public List<Param> params;
        @Getter
        @Setter
        public Return returning;
        @Getter
        @Setter
        public List<Annotation> annotations;
        @Getter
        @Setter
        public String visibility;
        @Getter
        @Setter
        public String name;

    }

    public class Param implements Serializable {

        @Getter
        @Setter
        public String doc;
        @Getter
        @Setter
        public String name;
        @Getter
        @Setter
        public Object value;
        @Getter
        @Setter
        public String type;
    }

    public class Return implements Serializable {
        @Getter
        @Setter
        public String doc;
        @Getter
        @Setter
        public String type;
    }
}
