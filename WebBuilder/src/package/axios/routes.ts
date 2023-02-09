export const routerLinks = {
        home: "/gg",
        loginForm: "/auth/login",
};
export const routers = {
        category: {
                create: "/api/category",
                update: "/api/category",
        },
        order: {
                addToCart: "/api/cart/add",
                getCart: "/api/cart",
                create: "/api/order",
        },
        user: {
                changePassword: "/api/user/password",
                update: "/api/user",
                login: "/api/auth/login",
                register: "/api/auth/register",
        },
        product: {
                create: "/api/product",
                update: "/api/product",
        },
};
