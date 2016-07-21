using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAreaLayout : vtkTreeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAreaLayout";

		public new static readonly string MRClassNameKey;

		static vtkAreaLayout()
		{
			vtkAreaLayout.MRClassNameKey = "class vtkAreaLayout";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAreaLayout.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAreaLayout"));
		}

		public vtkAreaLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAreaLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAreaLayout New()
		{
			vtkAreaLayout result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAreaLayout.vtkAreaLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAreaLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAreaLayout() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAreaLayout.vtkAreaLayout_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAreaLayout_EdgeRoutingPointsOff_01(HandleRef pThis);

		public virtual void EdgeRoutingPointsOff()
		{
			vtkAreaLayout.vtkAreaLayout_EdgeRoutingPointsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAreaLayout_EdgeRoutingPointsOn_02(HandleRef pThis);

		public virtual void EdgeRoutingPointsOn()
		{
			vtkAreaLayout.vtkAreaLayout_EdgeRoutingPointsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkAreaLayout_FindVertex_03(HandleRef pThis, IntPtr pnt);

		public long FindVertex(IntPtr pnt)
		{
			return vtkAreaLayout.vtkAreaLayout_FindVertex_03(base.GetCppThis(), pnt);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAreaLayout_GetAreaArrayName_04(HandleRef pThis);

		public virtual string GetAreaArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkAreaLayout.vtkAreaLayout_GetAreaArrayName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAreaLayout_GetBoundingArea_05(HandleRef pThis, long id, IntPtr sinfo);

		public void GetBoundingArea(long id, IntPtr sinfo)
		{
			vtkAreaLayout.vtkAreaLayout_GetBoundingArea_05(base.GetCppThis(), id, sinfo);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkAreaLayout_GetEdgeRoutingPoints_06(HandleRef pThis);

		public virtual bool GetEdgeRoutingPoints()
		{
			return vtkAreaLayout.vtkAreaLayout_GetEdgeRoutingPoints_06(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAreaLayout_GetLayoutStrategy_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAreaLayoutStrategy GetLayoutStrategy()
		{
			vtkAreaLayoutStrategy vtkAreaLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAreaLayout.vtkAreaLayout_GetLayoutStrategy_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaLayoutStrategy = (vtkAreaLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaLayoutStrategy.Register(null);
				}
			}
			return vtkAreaLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern uint vtkAreaLayout_GetMTime_08(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkAreaLayout.vtkAreaLayout_GetMTime_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAreaLayout_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAreaLayout.vtkAreaLayout_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAreaLayout_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAreaLayout.vtkAreaLayout_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAreaLayout_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAreaLayout NewInstance()
		{
			vtkAreaLayout result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAreaLayout.vtkAreaLayout_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAreaLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAreaLayout_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAreaLayout SafeDownCast(vtkObjectBase o)
		{
			vtkAreaLayout vtkAreaLayout = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAreaLayout.vtkAreaLayout_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaLayout = (vtkAreaLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaLayout.Register(null);
				}
			}
			return vtkAreaLayout;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAreaLayout_SetAreaArrayName_14(HandleRef pThis, string _arg);

		public virtual void SetAreaArrayName(string _arg)
		{
			vtkAreaLayout.vtkAreaLayout_SetAreaArrayName_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAreaLayout_SetEdgeRoutingPoints_15(HandleRef pThis, byte _arg);

		public virtual void SetEdgeRoutingPoints(bool _arg)
		{
			vtkAreaLayout.vtkAreaLayout_SetEdgeRoutingPoints_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAreaLayout_SetLayoutStrategy_16(HandleRef pThis, HandleRef strategy);

		public void SetLayoutStrategy(vtkAreaLayoutStrategy strategy)
		{
			vtkAreaLayout.vtkAreaLayout_SetLayoutStrategy_16(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAreaLayout_SetSizeArrayName_17(HandleRef pThis, string name);

		public virtual void SetSizeArrayName(string name)
		{
			vtkAreaLayout.vtkAreaLayout_SetSizeArrayName_17(base.GetCppThis(), name);
		}
	}
}
