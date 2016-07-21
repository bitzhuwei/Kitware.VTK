using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTemporalDataSetCache : vtkTemporalDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalDataSetCache";

		public new static readonly string MRClassNameKey;

		static vtkTemporalDataSetCache()
		{
			vtkTemporalDataSetCache.MRClassNameKey = "class vtkTemporalDataSetCache";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalDataSetCache.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalDataSetCache"));
		}

		public vtkTemporalDataSetCache(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalDataSetCache_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalDataSetCache New()
		{
			vtkTemporalDataSetCache result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalDataSetCache.vtkTemporalDataSetCache_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalDataSetCache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTemporalDataSetCache() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTemporalDataSetCache.vtkTemporalDataSetCache_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalDataSetCache_GetCacheSize_01(HandleRef pThis);

		public virtual int GetCacheSize()
		{
			return vtkTemporalDataSetCache.vtkTemporalDataSetCache_GetCacheSize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalDataSetCache_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTemporalDataSetCache.vtkTemporalDataSetCache_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalDataSetCache_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTemporalDataSetCache.vtkTemporalDataSetCache_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalDataSetCache_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTemporalDataSetCache NewInstance()
		{
			vtkTemporalDataSetCache result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalDataSetCache.vtkTemporalDataSetCache_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalDataSetCache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalDataSetCache_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalDataSetCache SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalDataSetCache vtkTemporalDataSetCache = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalDataSetCache.vtkTemporalDataSetCache_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalDataSetCache = (vtkTemporalDataSetCache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalDataSetCache.Register(null);
				}
			}
			return vtkTemporalDataSetCache;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalDataSetCache_SetCacheSize_07(HandleRef pThis, int size);

		public void SetCacheSize(int size)
		{
			vtkTemporalDataSetCache.vtkTemporalDataSetCache_SetCacheSize_07(base.GetCppThis(), size);
		}
	}
}
