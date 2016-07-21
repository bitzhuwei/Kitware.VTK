using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageSeedConnectivity : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSeedConnectivity";

		public new static readonly string MRClassNameKey;

		static vtkImageSeedConnectivity()
		{
			vtkImageSeedConnectivity.MRClassNameKey = "class vtkImageSeedConnectivity";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSeedConnectivity.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSeedConnectivity"));
		}

		public vtkImageSeedConnectivity(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSeedConnectivity_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageSeedConnectivity New()
		{
			vtkImageSeedConnectivity result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSeedConnectivity.vtkImageSeedConnectivity_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSeedConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageSeedConnectivity() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageSeedConnectivity.vtkImageSeedConnectivity_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSeedConnectivity_AddSeed_01(HandleRef pThis, int num, IntPtr index);

		public void AddSeed(int num, IntPtr index)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_AddSeed_01(base.GetCppThis(), num, index);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSeedConnectivity_AddSeed_02(HandleRef pThis, int i0, int i1, int i2);

		public void AddSeed(int i0, int i1, int i2)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_AddSeed_02(base.GetCppThis(), i0, i1, i2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSeedConnectivity_AddSeed_03(HandleRef pThis, int i0, int i1);

		public void AddSeed(int i0, int i1)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_AddSeed_03(base.GetCppThis(), i0, i1);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSeedConnectivity_GetConnector_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageConnector GetConnector()
		{
			vtkImageConnector vtkImageConnector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSeedConnectivity.vtkImageSeedConnectivity_GetConnector_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageConnector = (vtkImageConnector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageConnector.Register(null);
				}
			}
			return vtkImageConnector;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSeedConnectivity_GetDimensionality_05(HandleRef pThis);

		public virtual int GetDimensionality()
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_GetDimensionality_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSeedConnectivity_GetInputConnectValue_06(HandleRef pThis);

		public virtual int GetInputConnectValue()
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_GetInputConnectValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSeedConnectivity_GetOutputConnectedValue_07(HandleRef pThis);

		public virtual int GetOutputConnectedValue()
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_GetOutputConnectedValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSeedConnectivity_GetOutputUnconnectedValue_08(HandleRef pThis);

		public virtual int GetOutputUnconnectedValue()
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_GetOutputUnconnectedValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSeedConnectivity_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSeedConnectivity_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSeedConnectivity_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageSeedConnectivity NewInstance()
		{
			vtkImageSeedConnectivity result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSeedConnectivity.vtkImageSeedConnectivity_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSeedConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSeedConnectivity_RemoveAllSeeds_13(HandleRef pThis);

		public void RemoveAllSeeds()
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_RemoveAllSeeds_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSeedConnectivity_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageSeedConnectivity SafeDownCast(vtkObjectBase o)
		{
			vtkImageSeedConnectivity vtkImageSeedConnectivity = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSeedConnectivity.vtkImageSeedConnectivity_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSeedConnectivity = (vtkImageSeedConnectivity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSeedConnectivity.Register(null);
				}
			}
			return vtkImageSeedConnectivity;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSeedConnectivity_SetDimensionality_15(HandleRef pThis, int _arg);

		public virtual void SetDimensionality(int _arg)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_SetDimensionality_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSeedConnectivity_SetInputConnectValue_16(HandleRef pThis, int _arg);

		public virtual void SetInputConnectValue(int _arg)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_SetInputConnectValue_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSeedConnectivity_SetOutputConnectedValue_17(HandleRef pThis, int _arg);

		public virtual void SetOutputConnectedValue(int _arg)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_SetOutputConnectedValue_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSeedConnectivity_SetOutputUnconnectedValue_18(HandleRef pThis, int _arg);

		public virtual void SetOutputUnconnectedValue(int _arg)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_SetOutputUnconnectedValue_18(base.GetCppThis(), _arg);
		}
	}
}
