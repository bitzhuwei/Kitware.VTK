using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenerateIndexArray : vtkDataObjectAlgorithm
	{
		public enum CELL_DATA_WrapperEnum
		{
			CELL_DATA = 2,
			EDGE_DATA = 4,
			POINT_DATA = 1,
			ROW_DATA = 0,
			VERTEX_DATA = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkGenerateIndexArray";

		public new static readonly string MRClassNameKey;

		static vtkGenerateIndexArray()
		{
			vtkGenerateIndexArray.MRClassNameKey = "class vtkGenerateIndexArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenerateIndexArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenerateIndexArray"));
		}

		public vtkGenerateIndexArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGenerateIndexArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenerateIndexArray New()
		{
			vtkGenerateIndexArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenerateIndexArray.vtkGenerateIndexArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenerateIndexArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenerateIndexArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenerateIndexArray.vtkGenerateIndexArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGenerateIndexArray_GetArrayName_01(HandleRef pThis);

		public virtual string GetArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGenerateIndexArray.vtkGenerateIndexArray_GetArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGenerateIndexArray_GetFieldType_02(HandleRef pThis);

		public virtual int GetFieldType()
		{
			return vtkGenerateIndexArray.vtkGenerateIndexArray_GetFieldType_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGenerateIndexArray_GetPedigreeID_03(HandleRef pThis);

		public virtual int GetPedigreeID()
		{
			return vtkGenerateIndexArray.vtkGenerateIndexArray_GetPedigreeID_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGenerateIndexArray_GetReferenceArrayName_04(HandleRef pThis);

		public virtual string GetReferenceArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkGenerateIndexArray.vtkGenerateIndexArray_GetReferenceArrayName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGenerateIndexArray_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenerateIndexArray.vtkGenerateIndexArray_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGenerateIndexArray_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenerateIndexArray.vtkGenerateIndexArray_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGenerateIndexArray_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenerateIndexArray NewInstance()
		{
			vtkGenerateIndexArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenerateIndexArray.vtkGenerateIndexArray_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenerateIndexArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGenerateIndexArray_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenerateIndexArray SafeDownCast(vtkObjectBase o)
		{
			vtkGenerateIndexArray vtkGenerateIndexArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenerateIndexArray.vtkGenerateIndexArray_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenerateIndexArray = (vtkGenerateIndexArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenerateIndexArray.Register(null);
				}
			}
			return vtkGenerateIndexArray;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGenerateIndexArray_SetArrayName_10(HandleRef pThis, string _arg);

		public virtual void SetArrayName(string _arg)
		{
			vtkGenerateIndexArray.vtkGenerateIndexArray_SetArrayName_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGenerateIndexArray_SetFieldType_11(HandleRef pThis, int _arg);

		public virtual void SetFieldType(int _arg)
		{
			vtkGenerateIndexArray.vtkGenerateIndexArray_SetFieldType_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGenerateIndexArray_SetPedigreeID_12(HandleRef pThis, int _arg);

		public virtual void SetPedigreeID(int _arg)
		{
			vtkGenerateIndexArray.vtkGenerateIndexArray_SetPedigreeID_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGenerateIndexArray_SetReferenceArrayName_13(HandleRef pThis, string _arg);

		public virtual void SetReferenceArrayName(string _arg)
		{
			vtkGenerateIndexArray.vtkGenerateIndexArray_SetReferenceArrayName_13(base.GetCppThis(), _arg);
		}
	}
}
