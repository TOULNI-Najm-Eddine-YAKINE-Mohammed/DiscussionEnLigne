
CREATE TABLE public."user"
(
    id serial NOT NULL,
    pseudo character varying(255) NOT NULL,
    CONSTRAINT user_pkey PRIMARY KEY (id),
    CONSTRAINT user_pseudo_key UNIQUE (pseudo)
);

CREATE TABLE message
(
    id serial NOT NULL,
    msg text NOT NULL,
    date timestamp without time zone NOT NULL,
    id_sender integer NOT NULL,
    id_receiver integer NOT NULL,
    CONSTRAINT message_pkey PRIMARY KEY (id),
    CONSTRAINT message_id_receiver_fkey FOREIGN KEY (id_receiver)
        REFERENCES public."user" (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
    CONSTRAINT message_id_sender_fkey FOREIGN KEY (id_sender)
        REFERENCES public."user" (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE
);

ALTER DATABASE "discussion" SET DateStyle=dmy, iso;