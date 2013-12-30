﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.32559
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tweetinvi.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tweetinvi.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/direct_messages/destroy.json?id={0}.
        /// </summary>
        internal static string Messages_Destroy {
            get {
                return ResourceManager.GetString("Messages_Destroy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/direct_messages/show.json?id={0}.
        /// </summary>
        internal static string Messages_GetDirectMessage {
            get {
                return ResourceManager.GetString("Messages_GetDirectMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/direct_messages/new.json?text={0}&amp;user_id={1}.
        /// </summary>
        internal static string Messages_SendToUserId {
            get {
                return ResourceManager.GetString("Messages_SendToUserId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/direct_messages/new.json?text={0}&amp;screen_name={1}.
        /// </summary>
        internal static string Messages_SendToUserScreenName {
            get {
                return ResourceManager.GetString("Messages_SendToUserScreenName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://stream.twitter.com/1.1/statuses/sample.json.
        /// </summary>
        internal static string Stream_Sample {
            get {
                return ResourceManager.GetString("Stream_Sample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://api.twitter.com/1.1/users/suggestions/{0}.json.
        /// </summary>
        internal static string SuggestedUserList_Get {
            get {
                return ResourceManager.GetString("SuggestedUserList_Get", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://api.twitter.com/1.1/users/suggestions/{0}/members.json.
        /// </summary>
        internal static string SuggestedUserList_GetMembers {
            get {
                return ResourceManager.GetString("SuggestedUserList_GetMembers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/friendships/create.json?follow={0}&amp;.
        /// </summary>
        internal static string TokenUser_CreateFriendship {
            get {
                return ResourceManager.GetString("TokenUser_CreateFriendship", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/friendships/destroy.json?.
        /// </summary>
        internal static string TokenUser_DestroyFriendship {
            get {
                return ResourceManager.GetString("TokenUser_DestroyFriendship", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/account/settings.json.
        /// </summary>
        internal static string TokenUser_GetAccountSettings {
            get {
                return ResourceManager.GetString("TokenUser_GetAccountSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/blocks/list.json?include_entities=true&amp;skip_status=false.
        /// </summary>
        internal static string TokenUser_GetBlockedUsers {
            get {
                return ResourceManager.GetString("TokenUser_GetBlockedUsers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/blocks/ids.json.
        /// </summary>
        internal static string TokenUser_GetBlockedUsersIds {
            get {
                return ResourceManager.GetString("TokenUser_GetBlockedUsersIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://api.twitter.com/1.1/statuses/home_timeline.json?count={0}trim_user={1}&amp;exclude_replies={2}&amp;since_id={3}&amp;max_id={4}&amp;contributor_details=true&amp;include_entities=true.
        /// </summary>
        internal static string TokenUser_GetHomeTimeline {
            get {
                return ResourceManager.GetString("TokenUser_GetHomeTimeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/direct_messages.json?count={0}.
        /// </summary>
        internal static string TokenUser_GetLatestDirectMessagesReceived {
            get {
                return ResourceManager.GetString("TokenUser_GetLatestDirectMessagesReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/direct_messages/sent.json?count={0}.
        /// </summary>
        internal static string TokenUser_GetLatestDirectMessagesSent {
            get {
                return ResourceManager.GetString("TokenUser_GetLatestDirectMessagesSent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://api.twitter.com/1.1/statuses/home_timeline.json?count={0}&amp;trim_user={1}&amp;exclude_replies={2}&amp;contributor_details=true&amp;include_entities=true.
        /// </summary>
        internal static string TokenUser_GetLatestHomeTimeline {
            get {
                return ResourceManager.GetString("TokenUser_GetLatestHomeTimeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://api.twitter.com/1.1/statuses/mentions_timeline.json?include_entities=1&amp;count={0}.
        /// </summary>
        internal static string TokenUser_GetLatestMentionTimeline {
            get {
                return ResourceManager.GetString("TokenUser_GetLatestMentionTimeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://api.twitter.com/1/statuses/retweets_of_me.json?count=100&amp;include_entities=1.
        /// </summary>
        internal static string TokenUser_GetRetweetsOfMe {
            get {
                return ResourceManager.GetString("TokenUser_GetRetweetsOfMe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://api.twitter.com/1.1/users/suggestions.json.
        /// </summary>
        internal static string TokenUser_GetUserSuggestions {
            get {
                return ResourceManager.GetString("TokenUser_GetUserSuggestions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/favorites/create.json?id={0}.
        /// </summary>
        internal static string Tweet_CreateFavourite {
            get {
                return ResourceManager.GetString("Tweet_CreateFavourite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/statuses/destroy/{0}.json.
        /// </summary>
        internal static string Tweet_Destroy {
            get {
                return ResourceManager.GetString("Tweet_Destroy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/favorites/destroy.json?id={0}.
        /// </summary>
        internal static string Tweet_DestroyFavourite {
            get {
                return ResourceManager.GetString("Tweet_DestroyFavourite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/statuses/show/{0}.json?include_entities=true.
        /// </summary>
        internal static string Tweet_GetFromIdWithEntities {
            get {
                return ResourceManager.GetString("Tweet_GetFromIdWithEntities", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/statuses/retweets/{0}.json.
        /// </summary>
        internal static string Tweet_GetRetweetOfTweet {
            get {
                return ResourceManager.GetString("Tweet_GetRetweetOfTweet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/statuses/update.json?status={0}&amp;trim_user={1}.
        /// </summary>
        internal static string Tweet_Publish {
            get {
                return ResourceManager.GetString("Tweet_Publish", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/statuses/update.json?status={0}&amp;trim_user={1}&amp;in_reply_to_status_id={2}.
        /// </summary>
        internal static string Tweet_PublishInReplyTo {
            get {
                return ResourceManager.GetString("Tweet_PublishInReplyTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/statuses/retweet/{0}.json.
        /// </summary>
        internal static string Tweet_PublishRetweet {
            get {
                return ResourceManager.GetString("Tweet_PublishRetweet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/statuses/update.json?status={0}&amp;trim_user={1}&amp;lat={2}&amp;long={3}&amp;display_coordinates={4}.
        /// </summary>
        internal static string Tweet_PublishWithGeo {
            get {
                return ResourceManager.GetString("Tweet_PublishWithGeo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/statuses/update.json?status={0}&amp;trim_user={1}&amp;lat={2}&amp;long={3}&amp;display_coordinates={4}&amp;in_reply_to_status_id={5}.
        /// </summary>
        internal static string Tweet_PublishWithGeoInReplyTo {
            get {
                return ResourceManager.GetString("Tweet_PublishWithGeoInReplyTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A tweet cannot be longer than 140 characters..
        /// </summary>
        internal static string Tweet_TextTooBig {
            get {
                return ResourceManager.GetString("Tweet_TextTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/users/contributees.json?.
        /// </summary>
        internal static string User_GetContributees {
            get {
                return ResourceManager.GetString("User_GetContributees", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/users/contributors.json?.
        /// </summary>
        internal static string User_GetContributors {
            get {
                return ResourceManager.GetString("User_GetContributors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/favorites/list.json?count={0}&amp;include_entities={1}&amp;since_id={2}&amp;max_id={3}.
        /// </summary>
        internal static string User_GetFavouritesBetweenIds {
            get {
                return ResourceManager.GetString("User_GetFavouritesBetweenIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/favorites/list.json?count={0}&amp;include_entities={1}&amp;since_id={2}.
        /// </summary>
        internal static string User_GetFavouritesSinceId {
            get {
                return ResourceManager.GetString("User_GetFavouritesSinceId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/favorites/list.json?count={0}&amp;include_entities={1}&amp;max_id={2}.
        /// </summary>
        internal static string User_GetFavouritesUntilId {
            get {
                return ResourceManager.GetString("User_GetFavouritesUntilId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/followers/ids.json?.
        /// </summary>
        internal static string User_GetFollowers {
            get {
                return ResourceManager.GetString("User_GetFollowers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/friends/ids.json?.
        /// </summary>
        internal static string User_GetFriends {
            get {
                return ResourceManager.GetString("User_GetFriends", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/friendships/show.json?.
        /// </summary>
        internal static string User_GetFriendship {
            get {
                return ResourceManager.GetString("User_GetFriendship", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/favorites/list.json?count={0}&amp;include_entities={1}.
        /// </summary>
        internal static string User_GetLastFavourites {
            get {
                return ResourceManager.GetString("User_GetLastFavourites", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/users/show.json?include_entities=true&amp;.
        /// </summary>
        internal static string User_GetUser {
            get {
                return ResourceManager.GetString("User_GetUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://api.twitter.com/1.1/statuses/user_timeline.json?include_rts=1&amp;include_entities=true&amp;count=200&amp;user_id={0}.
        /// </summary>
        internal static string User_GetUserTimeline {
            get {
                return ResourceManager.GetString("User_GetUserTimeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.twitter.com/1.1/users/lookup.json?include_entities=true.
        /// </summary>
        internal static string UserUtils_Lookup {
            get {
                return ResourceManager.GetString("UserUtils_Lookup", resourceCulture);
            }
        }
    }
}
