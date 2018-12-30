﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookSubscriptionTopic
    {
        APP_UNINSTALLED,
        ATTRIBUTED_SESSIONS_FIRST, ATTRIBUTED_SESSIONS_LAST,
        ATTRIBUTION_RISK,
        CARTS_CREATE, CARTS_UPDATE,
        CHANNELS_DELETE,
        CHECKOUTS_CREATE, CHECKOUTS_DELETE, CHECKOUTS_UPDATE,
        COLLECTIONS_CREATE, COLLECTIONS_DELETE, COLLECTIONS_UPDATE,
        COLLECTION_LISTINGS_ADD, COLLECTION_LISTINGS_REMOVE, COLLECTION_LISTINGS_UPDATE,
        COLLECTION_PUBLICATIONS_CREATE, COLLECTION_PUBLICATIONS_DELETE, COLLECTION_PUBLICATIONS_UPDATE,
        CUSTOMERS_CREATE, CUSTOMERS_DELETE, CUSTOMERS_DISABLE, CUSTOMERS_ENABLE, CUSTOMERS_UPDATE,
        CUSTOMER_GROUPS_CREATE, CUSTOMER_GROUPS_DELETE, CUSTOMER_GROUPS_UPDATE,
        DISPUTES_CREATE, DISPUTES_UPDATE,
        DRAFT_ORDERS_CREATE, DRAFT_ORDERS_DELETE, DRAFT_ORDERS_UPDATE,
        FULFILLMENTS_CREATE, FULFILLMENTS_UPDATE,
        FULFILLMENT_EVENTS_CREATE, FULFILLMENT_EVENTS_DELETE,
        INVENTORY_ITEMS_CREATE, INVENTORY_ITEMS_DELETE, INVENTORY_ITEMS_UPDATE,
        INVENTORY_LEVELS_CONNECT, INVENTORY_LEVELS_DISCONNECT, INVENTORY_LEVELS_UPDATE,
        LOCATIONS_CREATE, LOCATIONS_DELETE, LOCATIONS_UPDATE,
        ORDERS_CANCELLED, ORDERS_CREATE, ORDERS_DELETE, ORDERS_FULFILLED, ORDERS_PAID, ORDERS_PARTIALLY_FULFILLED, ORDERS_UPDATED,
        ORDER_TRANSACTIONS_CREATE,
        PRODUCTS_CREATE, PRODUCTS_DELETE, PRODUCTS_UPDATE,
        PRODUCT_LISTINGS_ADD, PRODUCT_LISTINGS_REMOVE, PRODUCT_LISTINGS_UPDATE,
        PRODUCT_PUBLICATIONS_CREATE, PRODUCT_PUBLICATIONS_DELETE, PRODUCT_PUBLICATIONS_UPDATE,
        REFUNDS_CREATE,
        SHIPPING_ADDRESSES_CREATE, SHIPPING_ADDRESSES_UPDATE,
        SHOP_UPDATE,
        TAX_SERVICES_CREATE, TAX_SERVICES_UPDATE,
        THEMES_CREATE, THEMES_DELETE, THEMES_PUBLISH, THEMES_UPDATE,
        VARIANTS_IN_STOCK, VARIANTS_OUT_OF_STOCK
    }
}
