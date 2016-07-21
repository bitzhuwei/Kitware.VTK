using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSQLDatabaseGraphSource : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLDatabaseGraphSource";

		public new static readonly string MRClassNameKey;

		static vtkSQLDatabaseGraphSource()
		{
			vtkSQLDatabaseGraphSource.MRClassNameKey = "class vtkSQLDatabaseGraphSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLDatabaseGraphSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLDatabaseGraphSource"));
		}

		public vtkSQLDatabaseGraphSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseGraphSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLDatabaseGraphSource New()
		{
			vtkSQLDatabaseGraphSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLDatabaseGraphSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSQLDatabaseGraphSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseGraphSource_AddLinkEdge_01(HandleRef pThis, string column1, string column2);

		public void AddLinkEdge(string column1, string column2)
		{
			vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_AddLinkEdge_01(base.GetCppThis(), column1, column2);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseGraphSource_AddLinkVertex_02(HandleRef pThis, string column, string domain, int hidden);

		public void AddLinkVertex(string column, string domain, int hidden)
		{
			vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_AddLinkVertex_02(base.GetCppThis(), column, domain, hidden);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseGraphSource_ClearLinkEdges_03(HandleRef pThis);

		public void ClearLinkEdges()
		{
			vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_ClearLinkEdges_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseGraphSource_ClearLinkVertices_04(HandleRef pThis);

		public void ClearLinkVertices()
		{
			vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_ClearLinkVertices_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseGraphSource_DirectedOff_05(HandleRef pThis);

		public virtual void DirectedOff()
		{
			vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_DirectedOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseGraphSource_DirectedOn_06(HandleRef pThis);

		public virtual void DirectedOn()
		{
			vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_DirectedOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseGraphSource_GenerateEdgePedigreeIdsOff_07(HandleRef pThis);

		public virtual void GenerateEdgePedigreeIdsOff()
		{
			vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_GenerateEdgePedigreeIdsOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseGraphSource_GenerateEdgePedigreeIdsOn_08(HandleRef pThis);

		public virtual void GenerateEdgePedigreeIdsOn()
		{
			vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_GenerateEdgePedigreeIdsOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkSQLDatabaseGraphSource_GetDirected_09(HandleRef pThis);

		public virtual bool GetDirected()
		{
			return vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_GetDirected_09(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseGraphSource_GetEdgePedigreeIdArrayName_10(HandleRef pThis);

		public virtual string GetEdgePedigreeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_GetEdgePedigreeIdArrayName_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkSQLDatabaseGraphSource_GetGenerateEdgePedigreeIds_11(HandleRef pThis);

		public virtual bool GetGenerateEdgePedigreeIds()
		{
			return vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_GetGenerateEdgePedigreeIds_11(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseGraphSource_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseGraphSource_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseGraphSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSQLDatabaseGraphSource NewInstance()
		{
			vtkSQLDatabaseGraphSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLDatabaseGraphSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseGraphSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLDatabaseGraphSource SafeDownCast(vtkObjectBase o)
		{
			vtkSQLDatabaseGraphSource vtkSQLDatabaseGraphSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLDatabaseGraphSource = (vtkSQLDatabaseGraphSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLDatabaseGraphSource.Register(null);
				}
			}
			return vtkSQLDatabaseGraphSource;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseGraphSource_SetDirected_17(HandleRef pThis, byte _arg);

		public virtual void SetDirected(bool _arg)
		{
			vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_SetDirected_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseGraphSource_SetEdgePedigreeIdArrayName_18(HandleRef pThis, string _arg);

		public virtual void SetEdgePedigreeIdArrayName(string _arg)
		{
			vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_SetEdgePedigreeIdArrayName_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseGraphSource_SetGenerateEdgePedigreeIds_19(HandleRef pThis, byte _arg);

		public virtual void SetGenerateEdgePedigreeIds(bool _arg)
		{
			vtkSQLDatabaseGraphSource.vtkSQLDatabaseGraphSource_SetGenerateEdgePedigreeIds_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
