using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractSelectedRows : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedRows";

		public new static readonly string MRClassNameKey;

		static vtkExtractSelectedRows()
		{
			vtkExtractSelectedRows.MRClassNameKey = "class vtkExtractSelectedRows";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedRows.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedRows"));
		}

		public vtkExtractSelectedRows(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedRows_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedRows New()
		{
			vtkExtractSelectedRows result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedRows.vtkExtractSelectedRows_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedRows)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractSelectedRows() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractSelectedRows.vtkExtractSelectedRows_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedRows_AddOriginalRowIdsArrayOff_01(HandleRef pThis);

		public virtual void AddOriginalRowIdsArrayOff()
		{
			vtkExtractSelectedRows.vtkExtractSelectedRows_AddOriginalRowIdsArrayOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedRows_AddOriginalRowIdsArrayOn_02(HandleRef pThis);

		public virtual void AddOriginalRowIdsArrayOn()
		{
			vtkExtractSelectedRows.vtkExtractSelectedRows_AddOriginalRowIdsArrayOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedRows_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkExtractSelectedRows.vtkExtractSelectedRows_FillInputPortInformation_03(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkExtractSelectedRows_GetAddOriginalRowIdsArray_04(HandleRef pThis);

		public virtual bool GetAddOriginalRowIdsArray()
		{
			return vtkExtractSelectedRows.vtkExtractSelectedRows_GetAddOriginalRowIdsArray_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedRows_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractSelectedRows.vtkExtractSelectedRows_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedRows_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedRows.vtkExtractSelectedRows_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedRows_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractSelectedRows NewInstance()
		{
			vtkExtractSelectedRows result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedRows.vtkExtractSelectedRows_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedRows)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedRows_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedRows SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedRows vtkExtractSelectedRows = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedRows.vtkExtractSelectedRows_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedRows = (vtkExtractSelectedRows)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedRows.Register(null);
				}
			}
			return vtkExtractSelectedRows;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedRows_SetAddOriginalRowIdsArray_10(HandleRef pThis, byte _arg);

		public virtual void SetAddOriginalRowIdsArray(bool _arg)
		{
			vtkExtractSelectedRows.vtkExtractSelectedRows_SetAddOriginalRowIdsArray_10(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedRows_SetAnnotationLayersConnection_11(HandleRef pThis, HandleRef arg0);

		public void SetAnnotationLayersConnection(vtkAlgorithmOutput arg0)
		{
			vtkExtractSelectedRows.vtkExtractSelectedRows_SetAnnotationLayersConnection_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedRows_SetSelectionConnection_12(HandleRef pThis, HandleRef arg0);

		public void SetSelectionConnection(vtkAlgorithmOutput arg0)
		{
			vtkExtractSelectedRows.vtkExtractSelectedRows_SetSelectionConnection_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
