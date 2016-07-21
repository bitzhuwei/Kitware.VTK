using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAddMembershipArray : vtkPassInputTypeAlgorithm
	{
		public enum CELL_DATA_WrapperEnum
		{
			CELL_DATA = 2,
			EDGE_DATA = 4,
			FIELD_DATA = 0,
			POINT_DATA,
			ROW_DATA = 5,
			VERTEX_DATA = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkAddMembershipArray";

		public new static readonly string MRClassNameKey;

		static vtkAddMembershipArray()
		{
			vtkAddMembershipArray.MRClassNameKey = "class vtkAddMembershipArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAddMembershipArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAddMembershipArray"));
		}

		public vtkAddMembershipArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAddMembershipArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAddMembershipArray New()
		{
			vtkAddMembershipArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAddMembershipArray.vtkAddMembershipArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAddMembershipArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAddMembershipArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAddMembershipArray.vtkAddMembershipArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAddMembershipArray_GetFieldType_01(HandleRef pThis);

		public virtual int GetFieldType()
		{
			return vtkAddMembershipArray.vtkAddMembershipArray_GetFieldType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAddMembershipArray_GetFieldTypeMaxValue_02(HandleRef pThis);

		public virtual int GetFieldTypeMaxValue()
		{
			return vtkAddMembershipArray.vtkAddMembershipArray_GetFieldTypeMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAddMembershipArray_GetFieldTypeMinValue_03(HandleRef pThis);

		public virtual int GetFieldTypeMinValue()
		{
			return vtkAddMembershipArray.vtkAddMembershipArray_GetFieldTypeMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAddMembershipArray_GetInputArrayName_04(HandleRef pThis);

		public virtual string GetInputArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkAddMembershipArray.vtkAddMembershipArray_GetInputArrayName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAddMembershipArray_GetInputValues_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractArray GetInputValues()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAddMembershipArray.vtkAddMembershipArray_GetInputValues_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAddMembershipArray_GetOutputArrayName_06(HandleRef pThis);

		public virtual string GetOutputArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkAddMembershipArray.vtkAddMembershipArray_GetOutputArrayName_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAddMembershipArray_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAddMembershipArray.vtkAddMembershipArray_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAddMembershipArray_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAddMembershipArray.vtkAddMembershipArray_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAddMembershipArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAddMembershipArray NewInstance()
		{
			vtkAddMembershipArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAddMembershipArray.vtkAddMembershipArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAddMembershipArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAddMembershipArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAddMembershipArray SafeDownCast(vtkObjectBase o)
		{
			vtkAddMembershipArray vtkAddMembershipArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAddMembershipArray.vtkAddMembershipArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAddMembershipArray = (vtkAddMembershipArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAddMembershipArray.Register(null);
				}
			}
			return vtkAddMembershipArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAddMembershipArray_SetFieldType_12(HandleRef pThis, int _arg);

		public virtual void SetFieldType(int _arg)
		{
			vtkAddMembershipArray.vtkAddMembershipArray_SetFieldType_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAddMembershipArray_SetInputArrayName_13(HandleRef pThis, string _arg);

		public virtual void SetInputArrayName(string _arg)
		{
			vtkAddMembershipArray.vtkAddMembershipArray_SetInputArrayName_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAddMembershipArray_SetInputValues_14(HandleRef pThis, HandleRef arg0);

		public void SetInputValues(vtkAbstractArray arg0)
		{
			vtkAddMembershipArray.vtkAddMembershipArray_SetInputValues_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAddMembershipArray_SetOutputArrayName_15(HandleRef pThis, string _arg);

		public virtual void SetOutputArrayName(string _arg)
		{
			vtkAddMembershipArray.vtkAddMembershipArray_SetOutputArrayName_15(base.GetCppThis(), _arg);
		}
	}
}
