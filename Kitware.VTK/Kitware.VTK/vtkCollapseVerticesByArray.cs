using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCollapseVerticesByArray : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCollapseVerticesByArray";

		public new static readonly string MRClassNameKey;

		static vtkCollapseVerticesByArray()
		{
			vtkCollapseVerticesByArray.MRClassNameKey = "class vtkCollapseVerticesByArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollapseVerticesByArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollapseVerticesByArray"));
		}

		public vtkCollapseVerticesByArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCollapseVerticesByArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCollapseVerticesByArray New()
		{
			vtkCollapseVerticesByArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollapseVerticesByArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCollapseVerticesByArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_AddAggregateEdgeArray_01(HandleRef pThis, string arrName);

		public void AddAggregateEdgeArray(string arrName)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_AddAggregateEdgeArray_01(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_AllowSelfLoopsOff_02(HandleRef pThis);

		public virtual void AllowSelfLoopsOff()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_AllowSelfLoopsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_AllowSelfLoopsOn_03(HandleRef pThis);

		public virtual void AllowSelfLoopsOn()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_AllowSelfLoopsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_ClearAggregateEdgeArray_04(HandleRef pThis);

		public void ClearAggregateEdgeArray()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_ClearAggregateEdgeArray_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_CountEdgesCollapsedOff_05(HandleRef pThis);

		public virtual void CountEdgesCollapsedOff()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_CountEdgesCollapsedOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_CountEdgesCollapsedOn_06(HandleRef pThis);

		public virtual void CountEdgesCollapsedOn()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_CountEdgesCollapsedOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_CountVerticesCollapsedOff_07(HandleRef pThis);

		public virtual void CountVerticesCollapsedOff()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_CountVerticesCollapsedOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_CountVerticesCollapsedOn_08(HandleRef pThis);

		public virtual void CountVerticesCollapsedOn()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_CountVerticesCollapsedOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkCollapseVerticesByArray_GetAllowSelfLoops_09(HandleRef pThis);

		public virtual bool GetAllowSelfLoops()
		{
			return vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetAllowSelfLoops_09(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkCollapseVerticesByArray_GetCountEdgesCollapsed_10(HandleRef pThis);

		public virtual bool GetCountEdgesCollapsed()
		{
			return vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetCountEdgesCollapsed_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkCollapseVerticesByArray_GetCountVerticesCollapsed_11(HandleRef pThis);

		public virtual bool GetCountVerticesCollapsed()
		{
			return vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetCountVerticesCollapsed_11(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCollapseVerticesByArray_GetEdgesCollapsedArray_12(HandleRef pThis);

		public virtual string GetEdgesCollapsedArray()
		{
			return Marshal.PtrToStringAnsi(vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetEdgesCollapsedArray_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCollapseVerticesByArray_GetVertexArray_13(HandleRef pThis);

		public virtual string GetVertexArray()
		{
			return Marshal.PtrToStringAnsi(vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetVertexArray_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCollapseVerticesByArray_GetVerticesCollapsedArray_14(HandleRef pThis);

		public virtual string GetVerticesCollapsedArray()
		{
			return Marshal.PtrToStringAnsi(vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetVerticesCollapsedArray_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCollapseVerticesByArray_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCollapseVerticesByArray_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCollapseVerticesByArray_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCollapseVerticesByArray NewInstance()
		{
			vtkCollapseVerticesByArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollapseVerticesByArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCollapseVerticesByArray_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCollapseVerticesByArray SafeDownCast(vtkObjectBase o)
		{
			vtkCollapseVerticesByArray vtkCollapseVerticesByArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollapseVerticesByArray = (vtkCollapseVerticesByArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollapseVerticesByArray.Register(null);
				}
			}
			return vtkCollapseVerticesByArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_SetAllowSelfLoops_20(HandleRef pThis, byte _arg);

		public virtual void SetAllowSelfLoops(bool _arg)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SetAllowSelfLoops_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_SetCountEdgesCollapsed_21(HandleRef pThis, byte _arg);

		public virtual void SetCountEdgesCollapsed(bool _arg)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SetCountEdgesCollapsed_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_SetCountVerticesCollapsed_22(HandleRef pThis, byte _arg);

		public virtual void SetCountVerticesCollapsed(bool _arg)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SetCountVerticesCollapsed_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_SetEdgesCollapsedArray_23(HandleRef pThis, string _arg);

		public virtual void SetEdgesCollapsedArray(string _arg)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SetEdgesCollapsedArray_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_SetVertexArray_24(HandleRef pThis, string _arg);

		public virtual void SetVertexArray(string _arg)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SetVertexArray_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseVerticesByArray_SetVerticesCollapsedArray_25(HandleRef pThis, string _arg);

		public virtual void SetVerticesCollapsedArray(string _arg)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SetVerticesCollapsedArray_25(base.GetCppThis(), _arg);
		}
	}
}
