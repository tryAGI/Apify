#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ScheduleCreateAction : global::System.IEquatable<ScheduleCreateAction>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActor? RunActor { get; init; }
#else
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActor? RunActor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunActor))]
#endif
        public bool IsRunActor => RunActor != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask? RunActorTask { get; init; }
#else
        public global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask? RunActorTask { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunActorTask))]
#endif
        public bool IsRunActorTask => RunActorTask != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScheduleCreateAction(global::Apify.ScheduleCreateActionScheduleCreateActionRunActor value) => new ScheduleCreateAction((global::Apify.ScheduleCreateActionScheduleCreateActionRunActor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleCreateActionScheduleCreateActionRunActor?(ScheduleCreateAction @this) => @this.RunActor;

        /// <summary>
        /// 
        /// </summary>
        public ScheduleCreateAction(global::Apify.ScheduleCreateActionScheduleCreateActionRunActor? value)
        {
            RunActor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScheduleCreateAction(global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask value) => new ScheduleCreateAction((global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask?(ScheduleCreateAction @this) => @this.RunActorTask;

        /// <summary>
        /// 
        /// </summary>
        public ScheduleCreateAction(global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask? value)
        {
            RunActorTask = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ScheduleCreateAction(
            global::Apify.ScheduleCreateActionScheduleCreateActionRunActor? runActor,
            global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask? runActorTask
            )
        {
            RunActor = runActor;
            RunActorTask = runActorTask;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RunActorTask as object ??
            RunActor as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RunActor?.ToString() ??
            RunActorTask?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRunActor && !IsRunActorTask || !IsRunActor && IsRunActorTask;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.ScheduleCreateActionScheduleCreateActionRunActor?, TResult>? runActor = null,
            global::System.Func<global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask?, TResult>? runActorTask = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunActor && runActor != null)
            {
                return runActor(RunActor!);
            }
            else if (IsRunActorTask && runActorTask != null)
            {
                return runActorTask(RunActorTask!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ScheduleCreateActionScheduleCreateActionRunActor?>? runActor = null,
            global::System.Action<global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask?>? runActorTask = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunActor)
            {
                runActor?.Invoke(RunActor!);
            }
            else if (IsRunActorTask)
            {
                runActorTask?.Invoke(RunActorTask!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunActor,
                typeof(global::Apify.ScheduleCreateActionScheduleCreateActionRunActor),
                RunActorTask,
                typeof(global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ScheduleCreateAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleCreateActionScheduleCreateActionRunActor?>.Default.Equals(RunActor, other.RunActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleCreateActionScheduleCreateActionRunActorTask?>.Default.Equals(RunActorTask, other.RunActorTask) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ScheduleCreateAction obj1, ScheduleCreateAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScheduleCreateAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ScheduleCreateAction obj1, ScheduleCreateAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScheduleCreateAction o && Equals(o);
        }
    }
}
