using System;
namespace Cognitivo.API
{
    public class Enums
    {
        /// <summary>
        /// Sync with.
        /// </summary>
        public enum SyncWith
        {
            /// <summary>
            /// The production.
            /// </summary>
            Production,
            /// <summary>
            /// The playground.
            /// </summary>
            Playground,
            /// <summary>
            /// The Local
            /// </summary>
            Local,
        }

        /// <summary>
        /// Status.
        /// </summary>
        public enum Status 
        {
            /// <summary>
            /// The pending.
            /// </summary>
            Pending,
            /// <summary>
            /// The approved.
            /// </summary>
            Approved,
            /// <summary>
            /// The annulled.
            /// </summary>
            Annulled
        }

        /// <summary>
        /// Time span.
        /// </summary>
        public enum TimeSpan 
        {
            /// <summary>
            /// The last week.
            /// </summary>
            LastWeek,
            /// <summary>
            /// The last month.
            /// </summary>
            LastMonth
        }

        /// <summary>
        /// Item types.
        /// </summary>
        public enum ItemTypes
        {
            /// <summary>
            /// The stockable.
            /// </summary>
            Stockable,
            /// <summary>
            /// The service.
            /// </summary>
            Service,
            /// <summary>
            /// The made to order.
            /// </summary>
            MadeToOrder
        }

        /// <summary>
        /// RowStatus
        /// </summary>
        public enum Action
        {
            CreatedOnCloud=1,
            UpdatedOnCloud=2,
            CreateOnLocal = 3,
            UpdatedOnLocal =4,
            NoChanges=5

           
        }
    }
}
