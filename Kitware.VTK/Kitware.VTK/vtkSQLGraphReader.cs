using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSQLGraphReader : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLGraphReader";

		public new static readonly string MRClassNameKey;

		static vtkSQLGraphReader()
		{
			vtkSQLGraphReader.MRClassNameKey = "class vtkSQLGraphReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLGraphReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLGraphReader"));
		}

		public vtkSQLGraphReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLGraphReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLGraphReader New()
		{
			vtkSQLGraphReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLGraphReader.vtkSQLGraphReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSQLGraphReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSQLGraphReader.vtkSQLGraphReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_CollapseEdgesOff_01(HandleRef pThis);

		public virtual void CollapseEdgesOff()
		{
			vtkSQLGraphReader.vtkSQLGraphReader_CollapseEdgesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_CollapseEdgesOn_02(HandleRef pThis);

		public virtual void CollapseEdgesOn()
		{
			vtkSQLGraphReader.vtkSQLGraphReader_CollapseEdgesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_DirectedOff_03(HandleRef pThis);

		public virtual void DirectedOff()
		{
			vtkSQLGraphReader.vtkSQLGraphReader_DirectedOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_DirectedOn_04(HandleRef pThis);

		public virtual void DirectedOn()
		{
			vtkSQLGraphReader.vtkSQLGraphReader_DirectedOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkSQLGraphReader_GetCollapseEdges_05(HandleRef pThis);

		public virtual bool GetCollapseEdges()
		{
			return vtkSQLGraphReader.vtkSQLGraphReader_GetCollapseEdges_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkSQLGraphReader_GetDirected_06(HandleRef pThis);

		public virtual bool GetDirected()
		{
			return vtkSQLGraphReader.vtkSQLGraphReader_GetDirected_06(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLGraphReader_GetEdgeQuery_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSQLQuery GetEdgeQuery()
		{
			vtkSQLQuery vtkSQLQuery = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLGraphReader.vtkSQLGraphReader_GetEdgeQuery_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLQuery = (vtkSQLQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLQuery.Register(null);
				}
			}
			return vtkSQLQuery;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLGraphReader_GetSourceField_08(HandleRef pThis);

		public virtual string GetSourceField()
		{
			return Marshal.PtrToStringAnsi(vtkSQLGraphReader.vtkSQLGraphReader_GetSourceField_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLGraphReader_GetTargetField_09(HandleRef pThis);

		public virtual string GetTargetField()
		{
			return Marshal.PtrToStringAnsi(vtkSQLGraphReader.vtkSQLGraphReader_GetTargetField_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLGraphReader_GetVertexIdField_10(HandleRef pThis);

		public virtual string GetVertexIdField()
		{
			return Marshal.PtrToStringAnsi(vtkSQLGraphReader.vtkSQLGraphReader_GetVertexIdField_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLGraphReader_GetVertexQuery_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSQLQuery GetVertexQuery()
		{
			vtkSQLQuery vtkSQLQuery = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLGraphReader.vtkSQLGraphReader_GetVertexQuery_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLQuery = (vtkSQLQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLQuery.Register(null);
				}
			}
			return vtkSQLQuery;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLGraphReader_GetXField_12(HandleRef pThis);

		public virtual string GetXField()
		{
			return Marshal.PtrToStringAnsi(vtkSQLGraphReader.vtkSQLGraphReader_GetXField_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLGraphReader_GetYField_13(HandleRef pThis);

		public virtual string GetYField()
		{
			return Marshal.PtrToStringAnsi(vtkSQLGraphReader.vtkSQLGraphReader_GetYField_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLGraphReader_GetZField_14(HandleRef pThis);

		public virtual string GetZField()
		{
			return Marshal.PtrToStringAnsi(vtkSQLGraphReader.vtkSQLGraphReader_GetZField_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSQLGraphReader_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSQLGraphReader.vtkSQLGraphReader_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSQLGraphReader_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSQLGraphReader.vtkSQLGraphReader_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLGraphReader_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSQLGraphReader NewInstance()
		{
			vtkSQLGraphReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLGraphReader.vtkSQLGraphReader_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLGraphReader_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLGraphReader SafeDownCast(vtkObjectBase o)
		{
			vtkSQLGraphReader vtkSQLGraphReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLGraphReader.vtkSQLGraphReader_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLGraphReader = (vtkSQLGraphReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLGraphReader.Register(null);
				}
			}
			return vtkSQLGraphReader;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_SetCollapseEdges_20(HandleRef pThis, byte _arg);

		public virtual void SetCollapseEdges(bool _arg)
		{
			vtkSQLGraphReader.vtkSQLGraphReader_SetCollapseEdges_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_SetDirected_21(HandleRef pThis, byte _arg);

		public virtual void SetDirected(bool _arg)
		{
			vtkSQLGraphReader.vtkSQLGraphReader_SetDirected_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_SetEdgeQuery_22(HandleRef pThis, HandleRef q);

		public virtual void SetEdgeQuery(vtkSQLQuery q)
		{
			vtkSQLGraphReader.vtkSQLGraphReader_SetEdgeQuery_22(base.GetCppThis(), (q == null) ? default(HandleRef) : q.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_SetSourceField_23(HandleRef pThis, string _arg);

		public virtual void SetSourceField(string _arg)
		{
			vtkSQLGraphReader.vtkSQLGraphReader_SetSourceField_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_SetTargetField_24(HandleRef pThis, string _arg);

		public virtual void SetTargetField(string _arg)
		{
			vtkSQLGraphReader.vtkSQLGraphReader_SetTargetField_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_SetVertexIdField_25(HandleRef pThis, string _arg);

		public virtual void SetVertexIdField(string _arg)
		{
			vtkSQLGraphReader.vtkSQLGraphReader_SetVertexIdField_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_SetVertexQuery_26(HandleRef pThis, HandleRef q);

		public virtual void SetVertexQuery(vtkSQLQuery q)
		{
			vtkSQLGraphReader.vtkSQLGraphReader_SetVertexQuery_26(base.GetCppThis(), (q == null) ? default(HandleRef) : q.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_SetXField_27(HandleRef pThis, string _arg);

		public virtual void SetXField(string _arg)
		{
			vtkSQLGraphReader.vtkSQLGraphReader_SetXField_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_SetYField_28(HandleRef pThis, string _arg);

		public virtual void SetYField(string _arg)
		{
			vtkSQLGraphReader.vtkSQLGraphReader_SetYField_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLGraphReader_SetZField_29(HandleRef pThis, string _arg);

		public virtual void SetZField(string _arg)
		{
			vtkSQLGraphReader.vtkSQLGraphReader_SetZField_29(base.GetCppThis(), _arg);
		}
	}
}
