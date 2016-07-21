using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOverrideInformationCollection : vtkCollection
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOverrideInformationCollection";

		public new static readonly string MRClassNameKey;

		static vtkOverrideInformationCollection()
		{
			vtkOverrideInformationCollection.MRClassNameKey = "class vtkOverrideInformationCollection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOverrideInformationCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOverrideInformationCollection"));
		}

		public vtkOverrideInformationCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOverrideInformationCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOverrideInformationCollection New()
		{
			vtkOverrideInformationCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOverrideInformationCollection.vtkOverrideInformationCollection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverrideInformationCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOverrideInformationCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOverrideInformationCollection.vtkOverrideInformationCollection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkOverrideInformationCollection_AddItem_01(HandleRef pThis, HandleRef f);

		public void AddItem(vtkOverrideInformation f)
		{
			vtkOverrideInformationCollection.vtkOverrideInformationCollection_AddItem_01(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOverrideInformationCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkOverrideInformation GetNextItem()
		{
			vtkOverrideInformation vtkOverrideInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOverrideInformationCollection.vtkOverrideInformationCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverrideInformation = (vtkOverrideInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverrideInformation.Register(null);
				}
			}
			return vtkOverrideInformation;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkOverrideInformationCollection_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOverrideInformationCollection.vtkOverrideInformationCollection_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkOverrideInformationCollection_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOverrideInformationCollection.vtkOverrideInformationCollection_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOverrideInformationCollection_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOverrideInformationCollection NewInstance()
		{
			vtkOverrideInformationCollection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOverrideInformationCollection.vtkOverrideInformationCollection_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverrideInformationCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOverrideInformationCollection_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOverrideInformationCollection SafeDownCast(vtkObjectBase o)
		{
			vtkOverrideInformationCollection vtkOverrideInformationCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOverrideInformationCollection.vtkOverrideInformationCollection_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverrideInformationCollection = (vtkOverrideInformationCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverrideInformationCollection.Register(null);
				}
			}
			return vtkOverrideInformationCollection;
		}
	}
}
