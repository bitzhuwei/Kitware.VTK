using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataObjectTypes : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectTypes";

		public new static readonly string MRClassNameKey;

		static vtkDataObjectTypes()
		{
			vtkDataObjectTypes.MRClassNameKey = "class vtkDataObjectTypes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectTypes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectTypes"));
		}

		public vtkDataObjectTypes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectTypes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataObjectTypes New()
		{
			vtkDataObjectTypes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectTypes.vtkDataObjectTypes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectTypes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataObjectTypes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataObjectTypes.vtkDataObjectTypes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectTypes_GetClassNameFromTypeId_01(int typeId);

		public static string GetClassNameFromTypeId(int typeId)
		{
			return Marshal.PtrToStringAnsi(vtkDataObjectTypes.vtkDataObjectTypes_GetClassNameFromTypeId_01(typeId));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObjectTypes_GetTypeIdFromClassName_02(string classname);

		public static int GetTypeIdFromClassName(string classname)
		{
			return vtkDataObjectTypes.vtkDataObjectTypes_GetTypeIdFromClassName_02(classname);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObjectTypes_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataObjectTypes.vtkDataObjectTypes_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataObjectTypes_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectTypes.vtkDataObjectTypes_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectTypes_NewDataObject_06(string classname, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkDataObject NewDataObject(string classname)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectTypes.vtkDataObjectTypes_NewDataObject_06(classname, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectTypes_NewDataObject_07(int typeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkDataObject NewDataObject(int typeId)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectTypes.vtkDataObjectTypes_NewDataObject_07(typeId, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectTypes_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObjectTypes NewInstance()
		{
			vtkDataObjectTypes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectTypes.vtkDataObjectTypes_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectTypes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectTypes_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataObjectTypes SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectTypes vtkDataObjectTypes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectTypes.vtkDataObjectTypes_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectTypes = (vtkDataObjectTypes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectTypes.Register(null);
				}
			}
			return vtkDataObjectTypes;
		}
	}
}
