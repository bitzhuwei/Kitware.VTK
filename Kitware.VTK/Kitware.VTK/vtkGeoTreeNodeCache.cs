using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoTreeNodeCache : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoTreeNodeCache";

		public new static readonly string MRClassNameKey;

		static vtkGeoTreeNodeCache()
		{
			vtkGeoTreeNodeCache.MRClassNameKey = "class vtkGeoTreeNodeCache";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoTreeNodeCache.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoTreeNodeCache"));
		}

		public vtkGeoTreeNodeCache(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTreeNodeCache_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoTreeNodeCache New()
		{
			vtkGeoTreeNodeCache result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTreeNodeCache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoTreeNodeCache() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTreeNodeCache_GetCacheMaximumLimit_01(HandleRef pThis);

		public virtual int GetCacheMaximumLimit()
		{
			return vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_GetCacheMaximumLimit_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTreeNodeCache_GetCacheMinimumLimit_02(HandleRef pThis);

		public virtual int GetCacheMinimumLimit()
		{
			return vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_GetCacheMinimumLimit_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTreeNodeCache_GetSize_03(HandleRef pThis);

		public virtual int GetSize()
		{
			return vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_GetSize_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTreeNodeCache_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTreeNodeCache_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTreeNodeCache_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoTreeNodeCache NewInstance()
		{
			vtkGeoTreeNodeCache result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTreeNodeCache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNodeCache_RemoveNode_08(HandleRef pThis, HandleRef node);

		public void RemoveNode(vtkGeoTreeNode node)
		{
			vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_RemoveNode_08(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTreeNodeCache_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoTreeNodeCache SafeDownCast(vtkObjectBase o)
		{
			vtkGeoTreeNodeCache vtkGeoTreeNodeCache = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTreeNodeCache = (vtkGeoTreeNodeCache)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTreeNodeCache.Register(null);
				}
			}
			return vtkGeoTreeNodeCache;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNodeCache_SendToFront_10(HandleRef pThis, HandleRef node);

		public void SendToFront(vtkGeoTreeNode node)
		{
			vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_SendToFront_10(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNodeCache_SetCacheMaximumLimit_11(HandleRef pThis, int _arg);

		public virtual void SetCacheMaximumLimit(int _arg)
		{
			vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_SetCacheMaximumLimit_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTreeNodeCache_SetCacheMinimumLimit_12(HandleRef pThis, int _arg);

		public virtual void SetCacheMinimumLimit(int _arg)
		{
			vtkGeoTreeNodeCache.vtkGeoTreeNodeCache_SetCacheMinimumLimit_12(base.GetCppThis(), _arg);
		}
	}
}
