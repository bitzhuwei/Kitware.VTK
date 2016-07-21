using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageDataStreamer : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataStreamer";

		public new static readonly string MRClassNameKey;

		static vtkImageDataStreamer()
		{
			vtkImageDataStreamer.MRClassNameKey = "class vtkImageDataStreamer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDataStreamer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataStreamer"));
		}

		public vtkImageDataStreamer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataStreamer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDataStreamer New()
		{
			vtkImageDataStreamer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataStreamer.vtkImageDataStreamer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageDataStreamer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageDataStreamer.vtkImageDataStreamer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataStreamer_GetExtentTranslator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkExtentTranslator GetExtentTranslator()
		{
			vtkExtentTranslator vtkExtentTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataStreamer.vtkImageDataStreamer_GetExtentTranslator_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtentTranslator = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtentTranslator.Register(null);
				}
			}
			return vtkExtentTranslator;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDataStreamer_GetNumberOfStreamDivisions_02(HandleRef pThis);

		public virtual int GetNumberOfStreamDivisions()
		{
			return vtkImageDataStreamer.vtkImageDataStreamer_GetNumberOfStreamDivisions_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDataStreamer_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageDataStreamer.vtkImageDataStreamer_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDataStreamer_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageDataStreamer.vtkImageDataStreamer_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataStreamer_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageDataStreamer NewInstance()
		{
			vtkImageDataStreamer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataStreamer.vtkImageDataStreamer_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataStreamer_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDataStreamer SafeDownCast(vtkObjectBase o)
		{
			vtkImageDataStreamer vtkImageDataStreamer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataStreamer.vtkImageDataStreamer_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDataStreamer = (vtkImageDataStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDataStreamer.Register(null);
				}
			}
			return vtkImageDataStreamer;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDataStreamer_SetExtentTranslator_08(HandleRef pThis, HandleRef arg0);

		public virtual void SetExtentTranslator(vtkExtentTranslator arg0)
		{
			vtkImageDataStreamer.vtkImageDataStreamer_SetExtentTranslator_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDataStreamer_SetNumberOfStreamDivisions_09(HandleRef pThis, int _arg);

		public virtual void SetNumberOfStreamDivisions(int _arg)
		{
			vtkImageDataStreamer.vtkImageDataStreamer_SetNumberOfStreamDivisions_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDataStreamer_Update_10(HandleRef pThis);

		public override void Update()
		{
			vtkImageDataStreamer.vtkImageDataStreamer_Update_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDataStreamer_UpdateWholeExtent_11(HandleRef pThis);

		public override void UpdateWholeExtent()
		{
			vtkImageDataStreamer.vtkImageDataStreamer_UpdateWholeExtent_11(base.GetCppThis());
		}
	}
}
