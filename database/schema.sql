CREATE TABLE tasks (
    id SERIAL PRIMARY KEY,
    title VARCHAR(200) NOT NULL,
    description TEXT,
    priority VARCHAR(20) NOT NULL,
    status VARCHAR(20) NOT NULL
);

INSERT INTO tasks (title, description, priority, status)
VALUES
('Estudiar React Native', 'Preparar prueba técnica', 'HIGH', 'PENDING'),
('Diseñar API', 'Crear microservicio .NET', 'MEDIUM', 'IN_PROGRESS'),
('Leer documentación', 'Revisar arquitectura limpia', 'LOW', 'DONE');


CREATE OR REPLACE FUNCTION sp_get_tasks(
    p_status VARCHAR DEFAULT NULL,
    p_priority VARCHAR DEFAULT NULL
)
RETURNS TABLE(
    id INT,
    title VARCHAR,
    description TEXT,
    priority VARCHAR,
    status VARCHAR
)
LANGUAGE plpgsql
AS $$
BEGIN

RETURN QUERY
SELECT
    t.id,
    t.title,
    t.description,
    t.priority,
    t.status
FROM tasks t
WHERE
    (p_status IS NULL OR t.status = p_status)
AND
    (p_priority IS NULL OR t.priority = p_priority);

END;
$$;


CREATE OR REPLACE FUNCTION sp_get_task_by_id(
    p_id INT
)
RETURNS TABLE(
    id INT,
    title VARCHAR,
    description TEXT,
    priority VARCHAR,
    status VARCHAR
)
LANGUAGE plpgsql
AS $$
BEGIN

RETURN QUERY
SELECT
    t.id,
    t.title,
    t.description,
    t.priority,
    t.status
FROM tasks t
WHERE t.id = p_id;

END;
$$;