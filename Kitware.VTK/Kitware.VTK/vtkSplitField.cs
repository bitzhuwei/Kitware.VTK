using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSplitField : vtkDataSetAlgorithm
	{
		public enum FieldLocations
		{
			CELL_DATA = 2,
			DATA_OBJECT = 0,
			POINT_DATA
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSplitField";

		public new static readonly string MRClassNameKey;

		static vtkSplitField()
		{
			vtkSplitField.MRClassNameKey = "class vtkSplitField";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplitField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplitField"));
		}

		public vtkSplitField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSplitField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplitField New()
		{
			vtkSplitField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplitField.vtkSplitField_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplitField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSplitField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSplitField.vtkSplitField_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplitField_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSplitField.vtkSplitField_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSplitField_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSplitField.vtkSplitField_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSplitField_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSplitField NewInstance()
		{
			vtkSplitField result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplitField.vtkSplitField_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplitField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSplitField_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplitField SafeDownCast(vtkObjectBase o)
		{
			vtkSplitField vtkSplitField = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplitField.vtkSplitField_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplitField = (vtkSplitField)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplitField.Register(null);
				}
			}
			return vtkSplitField;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplitField_SetInputField_06(HandleRef pThis, int attributeType, int fieldLoc);

		public void SetInputField(int attributeType, int fieldLoc)
		{
			vtkSplitField.vtkSplitField_SetInputField_06(base.GetCppThis(), attributeType, fieldLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplitField_SetInputField_07(HandleRef pThis, string name, int fieldLoc);

		public void SetInputField(string name, int fieldLoc)
		{
			vtkSplitField.vtkSplitField_SetInputField_07(base.GetCppThis(), name, fieldLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplitField_SetInputField_08(HandleRef pThis, string name, string fieldLoc);

		public void SetInputField(string name, string fieldLoc)
		{
			vtkSplitField.vtkSplitField_SetInputField_08(base.GetCppThis(), name, fieldLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSplitField_Split_09(HandleRef pThis, int component, string arrayName);

		public void Split(int component, string arrayName)
		{
			vtkSplitField.vtkSplitField_Split_09(base.GetCppThis(), component, arrayName);
		}
	}
}
