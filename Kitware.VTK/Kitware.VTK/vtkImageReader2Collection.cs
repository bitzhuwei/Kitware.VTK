using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageReader2Collection : vtkCollection
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageReader2Collection";

		public new static readonly string MRClassNameKey;

		static vtkImageReader2Collection()
		{
			vtkImageReader2Collection.MRClassNameKey = "class vtkImageReader2Collection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageReader2Collection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReader2Collection"));
		}

		public vtkImageReader2Collection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2Collection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageReader2Collection New()
		{
			vtkImageReader2Collection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader2Collection.vtkImageReader2Collection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2Collection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageReader2Collection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageReader2Collection.vtkImageReader2Collection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2Collection_AddItem_01(HandleRef pThis, HandleRef arg0);

		public void AddItem(vtkImageReader2 arg0)
		{
			vtkImageReader2Collection.vtkImageReader2Collection_AddItem_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2Collection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageReader2 GetNextItem()
		{
			vtkImageReader2 vtkImageReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader2Collection.vtkImageReader2Collection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReader = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReader.Register(null);
				}
			}
			return vtkImageReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2Collection_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageReader2Collection.vtkImageReader2Collection_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2Collection_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageReader2Collection.vtkImageReader2Collection_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2Collection_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageReader2Collection NewInstance()
		{
			vtkImageReader2Collection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader2Collection.vtkImageReader2Collection_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2Collection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2Collection_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageReader2Collection SafeDownCast(vtkObjectBase o)
		{
			vtkImageReader2Collection vtkImageReader2Collection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader2Collection.vtkImageReader2Collection_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReader2Collection = (vtkImageReader2Collection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReader2Collection.Register(null);
				}
			}
			return vtkImageReader2Collection;
		}
	}
}
