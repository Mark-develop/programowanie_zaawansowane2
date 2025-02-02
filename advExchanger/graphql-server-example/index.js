const { ApolloServer, gql } = require("apollo-server");

// схема - это коллекция типов (`typeDefs`),
// которые определяют "форму" выполняемых запросов
const typeDefs = gql`
  # Пример комментария

  # Тип "Book" определяет поля, которые можно получить для книги
  type User {
  login: String
  password: String
}

type ExhData {
  exchto: String
}

  # Тип "Query" является особым: в нем указываются все запросы, которые
  # могут выполняться клиентом, а также тип, возвращаемый запросом. В данном случае
  # запрос "books" возвращает массив из 0 или более книг
  type Query {
    user: [User],
    exhData: [ExhData]
  }
`;

const User = [
  {
    login: "Mark",
    password: "111",
  }
];

const ExhData = [
    {
    exchto: "PLN"
    }
  ];

const resolvers = {
  Query: {
    user: () => User,
    exhData: () => ExhData,
  },
};

// В конструктор Сервера передается 2 аргумента:
// схема и набор резолверов
const server = new ApolloServer({ typeDefs, resolvers })

// Запускаем сервер
server.listen().then(({ url }) => {
  console.log(`🚀  Сервер запущен по адресу: ${url}`)
})

