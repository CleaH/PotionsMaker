Use PotionMaker;
select * from Ingredient
GO

truncate table Ingredient;

INSERT INTO Ingredient (nom, descriptionIngredient, R, V, B, toxicity, soin, amour, puissance, mana, intelligence, agilite)
VALUES 
    ('Hypoxis ( ou Herbe étoilée)', 
    'Une plante médicinale qui est utilisée dans le baume à l''herbe étoilée.', 
    250, 228, 77,
    -8, 8, 2, -2, 2, 0, -2
    ),

    ('Sauge', 
    ' Une herbe, utilisée sous forme de poudre dans la potion de mémoire.', 
    171, 150, 211,
    0, 0, 2, -2, 0, 9, -2
    ),

    ('Rue', 
    'Arbuste à feuilles persistantes, aux propriétés curatives : essence utilisée pour se remettre d''un empoisonnement, ainsi qu''un ingrédient dans la potion Felix Felicis.', 
    206, 206, 74,
    -10, 4, 2, -2, 2, 0, -2
    ),

    ('Cheveux de Boursouf',
    'Cheveux d''un boursouf, notamment utilisés dans la potion de rire.', 
    85, 59, 44,
    3, 2, 5, -3, -3, -4, 4
    ),

    ('Huile de margousier',
    'Une Huile extraite des graines du margousier, utilisée dans le baume pour bourgeon fongique de Fergus.', 
    244, 187,64,
    -8, 8, 2, -4, 4, -2, -2
    ),

    ('Venim de Nagini',
    'Venim utilisé dans la potion d''obtention de corps.', 
    208, 219, 217,
    10, -10, 0, -2, 4, -2, 3
    ),

    ('Pierre de Lune',
    'Une pierre qui réagit au rayon de lune et qui est utilisé dans les filtres de paix, d''amour et dans la potion No. 86.', 
    227, 230, 223,
    -2, 2, 10, -4, 2, 6, 2
    ),

    ('Sangsue',
    'Un poisson utilisé dans la preparation du polynectar.', 
    72, 75, 78,
    -6, 4, -6, 2, 4, -2, 0
    ),

    ('Lavande',
    'Fleur à l''influence calmante et à l''odeur agréable, utilisée dans la potion du souffle de feu et la breuvage de sommeil.', 
    149, 150, 226,
    -4, 3, 8, 2, -2, 0, 2
    ),

    ('Graine de feu', 
    'Graine d''un buisson ardent qui est utilisé comme antidote et garde une température élevée en toutes circonstances. Attention au brulure.', 
    247, 214, 82,
    -5, -8, 6, 6, -4, 0, -2
    ),

    ('Miel',
    'Subtance sucrée qui peut avoir des effets ... surprenants.', 
    226, 160, 56,
    -5, 5, 6, -2, 4, 2, 2
    ),

    (
        'Aconite Tue-Loup', 
        'Une plante qui est utilisé dans les potions anti-loup, mais aussi dans la potion d''eveil.',
        68, 60, 188,
        1, 2, 1, 4, 3, -1, 8
    ), 
    (
        'Venin d''acromentul', 
        'Venin d''araignée de la même espece qu''Aragog. ',
        238, 238, 238,
        8, -2, 3, 4, 2, 1, -2
    ), 
    (
        'Dars de Vers aveugle', 
        'Un dars de vers aveugle (effet magique aléatoire)',
        255, 239, 1,
        0, 0, 0, 0, 0, 0, 0
    ), 
    (
        'Amanite phalloïde', 
        'Un chapignon extremement toxique. Utilisé dans le bouillon d''amanite.',
        108, 120, 80,
        6, 1, 5, 2, -5, 3, 0
    ), 
    (
        'Sang de dragon', 
        'Du sang qui a de très nombreuses propriétés. Peut être utilisé comme nettoyant pour four, détachant, remède contre les verrues et ingrédient de potion.',
        103, 26, 23, 
        1, 5, -5, 6, 9, 6, -2
    ), 
    (
        'Bézoard', 
        'Une pierre qui se trouve dans l''estomac des chèvres et qui sert d''antidote à la plupart des potions. Il entre dans la composition de l''antidote aux poisons courants et est très rare.',
        254, 194, 76,
        -8, 3, 0, 0, 0, 0, 0
    ), 
    (
        'Menthe', 
        'Une plante qui est utilisé dans la célèbre potion contre la rage et dans la potion du souffle de feu. ',
        65, 154, 30,
        0, 5, 5, -1, 0, 0, 0
    ), 
    (
        'Eau salé', 
        'Bah ... C''est de l''eau salé quoi. Toutefois, attention au effet surprise. ',
        201, 232, 253,
        1, 1, 1, 1, 1, 1, 1
    ), 
    (
        'Bulbe de Scilla', 
        'Un bulbe de la plante Scilla qui est notamment utilisé dans la potion Felix Felicis (Chance Liquide).',
        148, 121, 136,
        0, 0, 0, 5, 5, 0, 3
    ), 
    (
        'Crin de licorne', 
        'L''ingredient majoritaire de la potion d''embellissement. ',
        166, 167, 173,
        0, 0, 8, 5, 9, 0, 0
    )

