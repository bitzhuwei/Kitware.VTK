using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageDotProduct : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDotProduct";

		public new static readonly string MRClassNameKey;

		static vtkImageDotProduct()
		{
			vtkImageDotProduct.MRClassNameKey = "class vtkImageDotProduct";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDotProduct.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDotProduct"));
		}

		public vtkImageDotProduct(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDotProduct_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDotProduct New()
		{
			vtkImageDotProduct result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDotProduct.vtkImageDotProduct_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDotProduct)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageDotProduct() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageDotProduct.vtkImageDotProduct_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDotProduct_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageDotProduct.vtkImageDotProduct_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDotProduct_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageDotProduct.vtkImageDotProduct_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDotProduct_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageDotProduct NewInstance()
		{
			vtkImageDotProduct result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDotProduct.vtkImageDotProduct_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDotProduct)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDotProduct_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDotProduct SafeDownCast(vtkObjectBase o)
		{
			vtkImageDotProduct vtkImageDotProduct = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDotProduct.vtkImageDotProduct_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDotProduct = (vtkImageDotProduct)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDotProduct.Register(null);
				}
			}
			return vtkImageDotProduct;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDotProduct_SetInput1_06(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput1(vtkDataObject arg0)
		{
			vtkImageDotProduct.vtkImageDotProduct_SetInput1_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDotProduct_SetInput2_07(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput2(vtkDataObject arg0)
		{
			vtkImageDotProduct.vtkImageDotProduct_SetInput2_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
