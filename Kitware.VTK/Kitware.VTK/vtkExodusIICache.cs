using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExodusIICache : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExodusIICache";

		public new static readonly string MRClassNameKey;

		static vtkExodusIICache()
		{
			vtkExodusIICache.MRClassNameKey = "class vtkExodusIICache";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExodusIICache.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExodusIICache"));
		}

		public vtkExodusIICache(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIICache_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExodusIICache New()
		{
			vtkExodusIICache result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusIICache.vtkExodusIICache_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIICache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExodusIICache() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExodusIICache.vtkExodusIICache_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIICache_Clear_01(HandleRef pThis);

		public void Clear()
		{
			vtkExodusIICache.vtkExodusIICache_Clear_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkExodusIICache_GetSpaceLeft_02(HandleRef pThis);

		public double GetSpaceLeft()
		{
			return vtkExodusIICache.vtkExodusIICache_GetSpaceLeft_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIICache_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExodusIICache.vtkExodusIICache_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIICache_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExodusIICache.vtkExodusIICache_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIICache_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExodusIICache NewInstance()
		{
			vtkExodusIICache result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusIICache.vtkExodusIICache_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIICache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusIICache_ReduceToSize_07(HandleRef pThis, double newSize);

		public int ReduceToSize(double newSize)
		{
			return vtkExodusIICache.vtkExodusIICache_ReduceToSize_07(base.GetCppThis(), newSize);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIICache_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExodusIICache SafeDownCast(vtkObjectBase o)
		{
			vtkExodusIICache vtkExodusIICache = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusIICache.vtkExodusIICache_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExodusIICache = (vtkExodusIICache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExodusIICache.Register(null);
				}
			}
			return vtkExodusIICache;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusIICache_SetCacheCapacity_09(HandleRef pThis, double sizeInMiB);

		public void SetCacheCapacity(double sizeInMiB)
		{
			vtkExodusIICache.vtkExodusIICache_SetCacheCapacity_09(base.GetCppThis(), sizeInMiB);
		}
	}
}
